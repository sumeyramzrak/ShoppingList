import { createStore } from "vuex";
import createPersistedState from "vuex-persistedstate";
import sessionStore from "./session";

const store = createStore({
  plugins: [createPersistedState({ key: "persisted" })],
  modules: {
    session: sessionStore,
  },
});
export default store;
