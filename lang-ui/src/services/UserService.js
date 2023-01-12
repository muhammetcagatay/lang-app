import AuthHeader from "../helpers/AuthHeader";
import Config from "../helpers/Config";

const UserService = {
  Create(firstname, lastname, age, city, country, email, password) {
    var requestOptions = {
      method: "POST",
      headers: AuthHeader.GetHeader(),
      body: JSON.stringify({
        firstname,
        lastname,
        age,
        city,
        country,
        email,
        password,
      }),
    };
    return fetch(Config.service.user.create, requestOptions)
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

export default UserService;
