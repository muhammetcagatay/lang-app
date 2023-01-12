import AuthHeader from "../helpers/AuthHeader";
import Config from "../helpers/Config";

const VocabularyService = {
  GetCourses() {
    var requestOptions = {
      method: "GET",
      headers: AuthHeader.GetHeader(),
    };
    return fetch(Config.service.vocabulary.getAll, requestOptions)
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

export default VocabularyService;
