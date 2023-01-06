import { useEffect, useState } from "react";

const useFetch = (url, requestOptions = {}) => {
  const [data, setData] = useState();
  const [statusCode, setStatusCode] = useState();
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch(url, requestOptions)
      .then((response) => {
        setStatusCode(response.status);
        return response.json();
      })
      .then((json) => {
        setData(json);
      })
      .catch((error) => {
        setError(error);
      });
  }, [url, requestOptions]);

  return { data, statusCode, error };
};

export default useFetch;
