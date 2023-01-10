import { createRouter, createWebHistory } from "vue-router";
import store from "./store";
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  linkActiveClass: "active",
  routes: [
    {
      path: "/login",
      name: "Login",
      component: () => import("./pages/Login.vue"),
    }
  ],
});
router.beforeEach((to, from, next) => {
  if (!store.state.session.token) {
    if (to.path !== "/login") {
      router.push("/login");
    }
  }
  
  return next();
});
export default router;
