<template>

  <body>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <button @click="addInfantry()" class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
      <h6 class="px-2"> 0 </h6>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
    </div>
    <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
      <button type="button" class="btn btn-outline-dark mdi mdi-minus fs-5"></button>
      <span class="px-2"> 0 </span>
      <button type="button" class="btn btn-outline-dark mdi mdi-plus fs-5"></button>
    </div>
  </body>

</template>


<script>

export default {

  setup() {

    return {

    }
  }
}
</script>


<style lang="scss" scoped>

</style>