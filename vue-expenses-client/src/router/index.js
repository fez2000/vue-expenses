import Vue from 'vue'
import VueRouter from 'vue-router'
import Overview from '@/views/Overview.vue'
import Expenses from '@/views/Expenses.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: Overview
  },
  {
    path: '/expenses',
    name: 'expenses',
    component: Expenses
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router