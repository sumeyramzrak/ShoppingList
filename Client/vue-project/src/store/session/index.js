export default {
    namespaced: true,
    state: () => ({
      token: null,
      displayName: null,
    }),
    mutations: {
      setToken(state, value) {
        state.token = value;
      },
      setDisplayName(state, value) {
        state.displayName = value;
      },
      logOut(state) {
        state.displayName = null;
        state.token = null;
      }
    },
  };
  