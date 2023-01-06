using AutoMapper;
using Newtonsoft.Json;
using Speaking.Models.Dtos;
using Speaking.Models.Entities;

namespace Speaking.Services
{
    public interface ISoundService
    {
        public Task<ScorDto.ScorResponseDto> ScorSound(int userId,int textId, IFormFile file);
    }
    public class SoundService : ISoundService
    {
        private readonly SpeakingDBContext _context;
        private readonly IMapper _mapper;

        public SoundService(SpeakingDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ScorDto.ScorResponseDto> ScorSound(int userId,int textId, IFormFile file)
        {
            var text = _context.Texts.Where(w => !w.IsDelete && w.Id== textId).FirstOrDefault();
            var user = _context.Users.Where(w => !w.IsDelete && w.Id== userId).FirstOrDefault();

            if(text!=null && user!=null)
            {
                var outputText = await SpeechToText(file);

                var scor = CompareTexts(text.TextContent, outputText);

                if(scor!=null)
                {
                    scor.UserId = userId;
                    scor.TextId = textId;

                    _context.Scors.Add(scor);
                    _context.SaveChanges();

                    var scorDto = _mapper.Map<ScorDto.ScorResponseDto>(scor);

                    return scorDto;
                }
            }

            return null;
        }
        private async Task<string> SpeechToText(IFormFile file)
        {
            byte[] buffer = new byte[file.Length];

            using (MemoryStream ms = new MemoryStream())
            {
                file.CopyTo(ms);
                buffer = ms.ToArray();
            }

            string apiUrl = "http://speech-recognition-service:5000/api/speech-to-text";

            HttpClient httpClient = new HttpClient();

            MultipartFormDataContent content = new MultipartFormDataContent();

            content.Add(new ByteArrayContent(buffer), "audio_file", "audio.wav");

            HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                HttpContent content1 = response.Content;
                string responseContent = await content1.ReadAsStringAsync();

                var text = JsonConvert.DeserializeObject<TextDto.TextSpeechAPIDto>(responseContent);

                return text.Text;
            }

            return null;
        }
        private Scor CompareTexts(string originalText , string outputText)
        {
            if(originalText == null || outputText == null)
            {
                return null;
            }

            var originalTextWords = originalText.Split(' ');
            var outputTextWords = outputText.Split(' ');

            int sameWord = 0;
            int differentWord = 0;

            foreach (var originalTextWord in originalTextWords)
            {
                if(outputTextWords.Any(a => a.Replace(" ","").ToLower() == originalTextWord.Replace(" ", "").ToLower()))
                {
                    sameWord++;
                }
                else
                {
                    differentWord++;
                }
            }

            var scor = new Scor()
            {
                TrueWord = sameWord,
                FalseWord = differentWord,
                AccuracyRate = ((double)sameWord / (double)originalTextWords.Length),
            };

            return scor;
        }
    }
}
