import axios from "axios";
import store from "../store";
export default {
  install: (app) => {
    const instance = axios.create({
      baseURL: "http://127.0.0.1:5173",
    });
    var config = { headers: {} };
    const addHeader = (contentType) => {
      if (contentType) {
        config.headers["Content-Type"] = contentType;
      }
      const token = store.state.session.token;
      if (token) {
        config.headers["Authorization"] = "Bearer " + token;
      }
      return config;
    };

    let ajax = {
      get: function (url) {
        return instance.get(url, addHeader());
      },
      post: function (url, data, contentType) {
        return instance.post(url, data, addHeader(contentType));
      },
      delete: function (url) {
        return instance.delete(url, addHeader());
      },
      put: function (url,data) {
        return instance.put(url,data, addHeader());
      },
    };
    app.config.globalProperties.$ajax = ajax;
  },
};
