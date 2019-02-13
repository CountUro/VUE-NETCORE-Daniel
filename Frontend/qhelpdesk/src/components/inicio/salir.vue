<template>
  <div>
    <h6>Saliendo ....</h6>
  </div>
</template>
<script>
export default {
  created () {
    this.salir()
  },

  methods: {
    salir () {
      this.$router.push({name: 'home'})
      this.$store.dispatch('salir')
    }
  }
}
</script>