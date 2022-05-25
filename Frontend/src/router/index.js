import { createRouter, createWebHashHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Login from '../views/Login.vue'
import Provider from '../views/Provider.vue'

const routes = [{
        path: '/',
        name: 'Search',
        component: Home
    },
    {
        path: '/Login',
        name: 'Login',
        component: Login
    },
    {
        path: '/Provider',
        name: 'Provider',
        component: Provider
    }
]

const router = createRouter({
    history: createWebHashHistory(),
    routes
})

export default router