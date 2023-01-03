<template>

  <body>
    <div class="bg-secondary">
      <div>
        <img src="../assets/img/BoardGameKey.png" class="img-fluid" alt="Main Board Game Pieces Key">
      </div>
      <div class="peg">
        <ul>
          <h1>Pegs</h1>
          <li class="text-danger">Red Pegs Track Damage</li>
          <li>Black Pegs Track Missiles on Cruisers</li>
        </ul>
      </div>
    </div>
  </body>

</template>


<script>
export default {
  setup() {
    return {}
  }
}
</script>


<style lang="scss" scoped>
.peg {
  padding: 1rem;
}
</style>