<script setup>
import Login from './pages/Login.vue'
import HelloWorld from './components/HelloWorld.vue'
import TheWelcome from './components/TheWelcome.vue'
</script>

<template>
  <div class="content">
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo/logo.png" width="125" height="125" />

    <div class="wrapper">
      <HelloWorld msg="SHOPPING LIST" />
    </div>
  </header>
  <main>
    <Login/>
  </main>
</div>

</template>

<style scoped>
header {
  line-height: 1.5;
}
.content
{ 
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  background-color: rgb(221, 213, 103);
  padding: 10px;
}
.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
