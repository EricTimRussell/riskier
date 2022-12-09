<template>
  <div>
    <h2>Land Units</h2>
    <ul>
      <h5>Infantry</h5>
      <li>1-Capital 1-Industry 3-Agriculture</li>
      <h5 class="pt-3">Special Forces</h5>
      <li>3-Capital 1-Industry 3-Agriculture</li>
      <h5 class="pt-3">Mech</h5>
      <li>2-Capital 2-Industry 3-Agriculture</li>
      <h5 class="pt-3">IFV</h5>
      <li>3-Capital 3-Industry 1-Agriculture</li>
      <h5 class="pt-3">MBT</h5>
      <li>4-Capital 4-Industry 1-Agriculture</li>
      <h5 class="pt-3">Artillery</h5>
      <li>1-Capital 3-Industry</li>
      <h5 class="pt-3">SS-Artillery</h5>
      <li>1-Capital 4-Industry</li>
      <h5 class="pt-3">Anti-Aircraft</h5>
      <li>3-Capital 1-Industry</li>
      <h5 class="pt-3">Supply Truck</h5>
      <li>1-Capital 1-Agriculture</li>
    </ul>
    <h2>Air Units</h2>
    <ul>
      <h5>Fighter Aircraft</h5>
      <li>4-Capital 4-Industry</li>
      <h5 class="pt-3">CAS</h5>
      <li>4-Capital 4-Industry</li>
      <h5 class="pt-3">Transport Aircraft</h5>
      <li>1-Capital 1-Industry</li>
    </ul>
    <h2>Navy Units</h2>
    <ul>
      <h5>Carrier</h5>
      <li>6-Capital 6-Industry 6-Agriculture</li>
      <h5 class="pt-3">Cruiser</h5>
      <li>5-Capital 5-Industry 2-Agriculture</li>
      <h5 class="pt-3">Destroyer</h5>
      <li>5-Capital 4-Industry 2-Agriculture</li>
    </ul>
    <h2>Buildings</h2>
    <ul>
      <h5>Warehouse</h5>
      <li>1-Capital 3-Agriculture</li>
      <h5 class="pt-3">Factory</h5>
      <li>2-Capital 2-Industry 1-Agriculture</li>
      <h5 class="pt-3">Airfield</h5>
      <li>2-Capital 1-Agriculture</li>
      <h5 class="pt-3">Naval Yard</h5>
      <li>2-Capital 2-Agriculture</li>
    </ul>
    <div class="modal-footer text-end sticky-bottom no-border">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
    </div>
  </div>
</template>


<script>
export default {
  setup() {
    return {}
  }
}
</script>


<style lang="scss" scoped>
.no-border {
  border: none;
}
</style>