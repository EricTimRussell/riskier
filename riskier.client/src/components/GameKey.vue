<template>

  <body>
    <div class="bg-secondary">
      <div>
        <img src="../assets/img/BoardGameKey.png" class="img-fluid" alt="Main Board Game Pieces Key">
      </div>
      <div class="peg">
        <ul>
          <h2>Pegs</h2>
          <li class="text-danger">Red Pegs Track Damage</li>
          <li>Black Pegs Track Missiles on Cruisers</li>
        </ul>
      </div>
      <div class="py-1">
        <ul>
          <h2>Acronym's</h2>
          <li>MB-"Main Board"</li>
          <li>CB-"Combat Board"</li>
          <li>Mech-"Mechanized Infantry"</li>
          <li>IFV-"Infantry Fighting Vehicle"</li>
          <li>MBT-"Main Battle Tank"</li>
          <li>SsArtillery-"Surface-to-Surface Missile Artillery"</li>
          <li>CAS-"Close Air Support"</li>
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