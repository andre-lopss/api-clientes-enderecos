import { createWebHistory, createRouter } from "vue-router";

const routes = [
    {
        path: "/",
        component: () => import("./components/TheWelcome.vue")
    },
    {
        path: "/vendedor/listar",
        component: () => import("./components/vendedor/Listar.vue")
    }
];
const router = createRouter({
    history: createWebHistory(),
    routes
});
export default router;
