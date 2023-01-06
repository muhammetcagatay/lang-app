import io
import wave

from flask import Flask, request, jsonify
import speech_recognition as sr

app = Flask(__name__)

@app.route('/api/speech-to-text', methods=['POST'])
def speech_to_text():
    audio_file = request.files['audio_file']
    audio_data = audio_file.read()
    audio_bytes = io.BytesIO(audio_data)

    r = sr.Recognizer()
    with sr.AudioFile(audio_bytes) as source:
        audio = r.record(source)
    text = r.recognize_google(audio)

    return jsonify({'text': text})

if __name__ == '__main__':
    app.run(debug=True)