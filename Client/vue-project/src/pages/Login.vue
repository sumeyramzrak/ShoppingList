<script setup>
import WelcomeItem from '../components/WelcomeItem.vue'
import DocumentationIcon from '../components/icons/IconDocumentation.vue'
import ToolingIcon from '../components/icons/IconTooling.vue'
import EcosystemIcon from '../components/icons/IconEcosystem.vue'
import CommunityIcon from '../components/icons/IconCommunity.vue'
import SupportIcon from '../components/icons/IconSupport.vue'
</script>
<template>
    <div id="app">
      <div id="alert" v-if="alert">{{ alert }}</div>
  
      <form @submit.prevent="loginWithPassword">
        <label>
          Email or username
          <input type="text" v-model="emailOrUsername" />
        </label>
        <label>
          Password
          <input type="password" v-model="password" />
        </label>
        <button type="submit">Log in</button>
      </form>
    </div>
  </template>

  <style scoped>
  button,
  input {
    display: block;
    margin-bottom: 10px;
  }
  #app
  {
    display: flex; 
    justify-content: center;
    align-items: center;
  }

  #alert {
    color: red;
    margin-bottom: 10px;
  }
</style>