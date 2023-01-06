using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Speaking.Models.Dtos;
using Speaking.Models.Entities;

namespace Speaking.Services
{
    public interface ITextService
    {
        public TextDto.TextResponseDto GetRandomText();
    }
    public class TextService : ITextService
    {
        private readonly SpeakingDBContext _context;
        private readonly IMapper _mapper;
        public TextService(SpeakingDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public TextDto.TextResponseDto GetRandomText()
        {
            var texts = _context.Texts.Where(w => !w.IsDelete).ToList();

            if (texts.Count > 0)
            {
                var random = new Random().Next(0, texts.Count);

                var text = texts.ElementAt(random);

                var textDto = _mapper.Map<TextDto.TextResponseDto>(text);

                return textDto;
            }

            return null;
        }
    }
}
