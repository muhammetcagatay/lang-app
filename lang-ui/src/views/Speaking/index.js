import { useEffect, useState } from "react";
import "./Speaking.css";
import { ReactMic } from "react-mic";
import { Button, Card, CardContent, Typography } from "@mui/material";
import { useStopwatch } from "react-timer-hook";
import SpeakingService from "../../services/SpeakingService";
import Utilities from "../../helpers/Utilities";
import axios from "axios";

const Speaking = () => {
  const { seconds, minutes, pause, reset } = useStopwatch({
    autoStart: false,
  });
  const [isRecording, setIsRecording] = useState(false);
  const [audioUrl, setAudioUrl] = useState("");
  const [text, setText] = useState("");
  const [textId, setTextId] = useState(1);
  const [title, setTitle] = useState("");
  const [trueWord, setTrueWord] = useState(0);
  const [falseWord, setFalseWord] = useState(0);
  const [accuracy, setAccuracy] = useState(0.0);
  const [outputText, setOutputText] = useState("");

  useEffect(() => {
    const getText = async () => {
      await SpeakingService.Text().then((response) => {
        setText(response.textContent);
        setTextId(response.id);
        setTitle(response.title);
      });
    };

    getText();
  }, []);

  const handleRecordClick = () => {
    if (isRecording === true) {
      pause();
    } else {
      reset();
    }
    setIsRecording(!isRecording);
  };

  const stopRecording = async (blobObject) => {
    setIsRecording(false);
    setAudioUrl(blobObject.blobURL);
  };

  const generateScor = async () => {
    setIsRecording(false);

    const token = JSON.parse(localStorage.getItem("auth"));

    const formData = new FormData();
    formData.append("userId", 1);
    formData.append("textId", textId);

    await fetch(audioUrl)
      .then((response) => response.arrayBuffer())
      .then((arrayBuffer) => {
        return Utilities.webm2wav(arrayBuffer);
      })
      .then(async (wavefile) => {
        console.log(wavefile);
        formData.append(
          "audioFile",
          new Blob([wavefile], { type: "audio/wav" })
        );
        try {
          const res = await axios.post(
            "http://localhost:5001/speakingservice/api/sound",
            formData,
            {
              headers: {
                Authorization: `Bearer ${token.accessToken}`,
              },
            }
          );
          console.log(res.data);
          setTrueWord(res.data.trueWord);
          setFalseWord(res.data.falseWord);
          setAccuracy(res.data.accuracy);
          setOutputText(res.data.outputText);
        } catch (ex) {
          console.log(ex);
        }
      });

    reset();
    pause();
  };

  return (
    <div className="text-center">
      <Card sx={{ minWidth: 275 }}>
        <CardContent>
          <Typography variant="h5" component="div">
            {title}
          </Typography>
          <Typography variant="body">{text}</Typography>
        </CardContent>
      </Card>
      <div>
        <div style={{ fontSize: "100px" }}>
          <span>{minutes}</span>:<span>{seconds}</span>
        </div>
        <Button variant="contained" onClick={handleRecordClick}>
          {isRecording ? "Stop Recording" : "Start Recording"}
        </Button>
      </div>
      <div>
        <ReactMic
          record={isRecording}
          onStop={stopRecording}
          strokeColor="#000000"
          className="sound-wave"
          audioBitsPerSecond={128000}
        />
      </div>
      <div>
        <Button variant="contained" onClick={generateScor}>
          Generate Scor
        </Button>
      </div>
      <br></br>
      <div>
        <Button variant="contained">Doğru Kelime Sayısı: {trueWord}</Button>
        <Button variant="contained">Yanlış Kelime Sayısı: {falseWord}</Button>
        <Button variant="contained">Doğruluk Oranı: {accuracy}</Button>
      </div>
      <div>
        <Card sx={{ minWidth: 275 }}>
          <CardContent>
            <Typography variant="h5" component="div">
              Seslendirme Sonucunuz
            </Typography>
            <Typography variant="body">{outputText}</Typography>
          </CardContent>
        </Card>
      </div>
    </div>
  );
};

export default Speaking;
