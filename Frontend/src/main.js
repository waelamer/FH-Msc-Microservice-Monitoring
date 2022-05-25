import * as Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
// import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.min.js'

// const MainApp = createApp(App,{
//     store,router  
// });
// Vue.use(VueResource);

Vue.createApp(App).use(store).use(router).mount('#app');

// MainApp.mount('#app');
// const Vm = App.mount('#app');
