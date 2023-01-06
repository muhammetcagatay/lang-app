FROM python:3.8

# Gereksinimleri kur
COPY src/Services/SpeechRecognition/requirements.txt src/Services/SpeechRecognition/
RUN pip install -r src/Services/SpeechRecognition/requirements.txt

# Uygulamayı kopyala
COPY src/Services/SpeechRecognition/app.py .

# Çalıştır
EXPOSE 5000
CMD [ "python3", "-m" , "flask", "run", "--host=0.0.0.0"]