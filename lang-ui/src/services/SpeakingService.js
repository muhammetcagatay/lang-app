import axios from "axios";
import AuthHeader from "../helpers/AuthHeader";
import Config from "../helpers/Config";

const SpeakingService = {
  Text() {
    var requestOptions = {
      method: "GET",
      headers: AuthHeader.GetHeader(),
    };
    return fetch(Config.service.speaking.text, requestOptions)
      .then((response) => {
        return response.json();
      })
      .then((json) => {
        return json;
      })
      .catch((error) => {
        return "Not connected to server";
      });
  },
};

export default SpeakingService;
