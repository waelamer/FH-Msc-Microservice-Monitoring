<template>
  <div class="container">
    <UserComponent></UserComponent>
  </div>
</template>
<script>
import UserComponent from '../components/UserComponent.vue'

export default {
  name: 'Login',
  components: {
    UserComponent
  }
}
</script>

