<template>
  <div class="mx-2">
    <h2 class="text-center py-2">Land Units</h2>
    <div>
      <div class="bg-light">
        <h5>Infantry</h5>
        <h6>1-Capital 1-Industry 3-Agriculture</h6>
      </div>
      <div>
        <h5 class="pt-3">Special Forces</h5>
        <h6>3-Capital 1-Industry 3-Agriculture</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">Mech</h5>
        <h6>2-Capital 2-Industry 3-Agriculture</h6>
      </div>
      <div>
        <h5 class="pt-3">IFV</h5>
        <h6>3-Capital 3-Industry 1-Agriculture</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">MBT</h5>
        <h6>4-Capital 4-Industry 1-Agriculture</h6>
      </div>
      <div>
        <h5 class="pt-3">Artillery</h5>
        <h6>1-Capital 3-Industry</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">SS-Artillery</h5>
        <h6>1-Capital 4-Industry</h6>
      </div>
      <div>
        <h5 class="pt-3">Anti-Aircraft</h5>
        <h6>3-Capital 1-Industry</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">Supply Truck</h5>
        <h6>1-Capital 1-Agriculture</h6>
      </div>
    </div>
    <h2 class="text-center py-2">Air Units</h2>
    <div>
      <div class="bg-light">
        <h5>Fighter Aircraft</h5>
        <h6>4-Capital 4-Industry</h6>
      </div>
      <div>
        <h5 class="pt-3">CAS</h5>
        <h6>4-Capital 4-Industry</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">Transport Aircraft</h5>
        <h6>1-Capital 1-Industry</h6>
      </div>
    </div>
    <h2 class="text-center py-2">Navy Units</h2>
    <div>
      <div class="bg-light">
        <h5>Carrier</h5>
        <h6>6-Capital 6-Industry 6-Agriculture</h6>
      </div>
      <div>
        <h5 class="pt-3">Cruiser</h5>
        <h6>5-Capital 5-Industry 2-Agriculture</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">Destroyer</h5>
        <h6>5-Capital 4-Industry 2-Agriculture</h6>
      </div>
    </div>
    <h2 class="text-center py-2">Buildings</h2>
    <div>
      <div>
        <h5 class="pt-3">Factory</h5>
        <h6>2-Capital 2-Industry 1-Agriculture</h6>
      </div>
      <div class="bg-light">
        <h5 class="pt-3">Airfield</h5>
        <h6>2-Capital 1-Agriculture</h6>
      </div>
      <div>
        <h5 class="pt-3">Naval Yard</h5>
        <h6>2-Capital 2-Agriculture</h6>
      </div>
    </div>
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