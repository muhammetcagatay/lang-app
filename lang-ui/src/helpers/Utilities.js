const Utilities = {
  webm2wav(arrayBuffer) {
    const WaveFile = require("wavefile").WaveFile;
    const audioCtx = new (window.AudioContext || window.webkitAudioContext)();
    return audioCtx.decodeAudioData(arrayBuffer).then((audioBuffer) => {
      const numberOfChannels = audioBuffer.numberOfChannels;
      const length = audioBuffer.length;
      const sampleRate = audioBuffer.sampleRate;
      const channelData = new Float32Array(length * numberOfChannels);

      for (let channel = 0; channel < numberOfChannels; channel++) {
        const channelDataSrc = audioBuffer.getChannelData(channel);
        channelData.set(channelDataSrc, channel * length);
      }

      const wav = new WaveFile();
      wav.fromScratch(1, sampleRate, "32f", channelData);
      return wav.toBuffer();
    });
  },
};

export default Utilities;
