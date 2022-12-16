<template>

  <main>

    <div class="text-center mb-4">
      <h2>Land Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Infantry: Offense-2D6</h5>
      <ul>
        <li>Vs Infantry: 5-8 (55.6%)</li>
        <li>Vs Mech: 7-10 (50%)</li>
        <li>Vs IFV: 7-8 (30.56%)</li>
        <li>Vs MBT: 7-10 (50%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Infantry: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 5-9 (66.7%)</li>
        <li>Wetlands D: 7-12 (58.3%) </li>
        <li>Jungle/Forest: D: 5-9 (66.7%)</li>
        <li>Desert/Grassland D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-12 (58.3%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Special Forces: Offense-2D6</h5>
      <ul>
        <li>Vs Infantry: 5-8, 11-12 (63.94%)</li>
        <li>Vs Mech: 7-12 (58.34%)</li>
        <li>Vs IFV: 7-8, 11-12 (38.9%)</li>
        <li>Vs MBT: 7-12 (58.34%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Special Force: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 5-9 (66.7%)</li>
        <li>Wetlands D: 7-12 (58.3%) </li>
        <li>Jungle/Forest: D: 5-9 (66.7%)</li>
        <li>Desert/Grassland D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-12 (58.3%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Mech: Offense-2D6</h5>
      <ul>
        <li>Vs Infantry: 5-9 (66.7%)</li>
        <li>Vs Mech: 7-11 (55.6%)</li>
        <li>Vs IFV: 2, 7-10 (52.8%)</li>
        <li>Vs MBT: 2, 7-9 (44.5%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Mech: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-12 (58.3%)</li>
        <li>Wetlands D: 7-9 (41.7%)</li>
        <li>Jungle/Forest D: 7-12 (58.3%)</li>
        <li>Desert/Grassland D: 7-10 (50%)</li>
        <li>Highlands D: 5-8 (55.6%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>IFV: Offense-2D6</h5>
      <ul>
        <li>Vs Infantry: 5-12 (77.8%)</li>
        <li>Vs Mech: 5-9 (66.7%)</li>
        <li>Vs IFV: 7-11 (55.6%)</li>
        <li>Vs MBT: 7-8 (30.6%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>IFV: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-10 (50%)</li>
        <li>Wetlands D: 7-8 (30.6%)</li>
        <li>Jungle/Forest D: 7-9 (41.7%)</li>
        <li>Desert/Grassland D: 5-8 (55.6%)</li>
        <li>Highlands D: 7-10 (50%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>MBT: Offense-2D6</h5>
      <ul>
        <li>Vs Infantry: 2, 7-12 (61.1%)</li>
        <li>Vs Mech: 5-9 (66.7%)</li>
        <li>Vs IFV: 5-12 (77.8%)</li>
        <li>Vs MBT: 7-12 (58.3%) </li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>MBT: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-10 (50%)</li>
        <li>Grassland/Desert D: 7-10 (50%)</li>
        <li>Forest D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-9 (41.7%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Artillery-D12</h5>
      <ul>
        <li>3 tile range on combat board</li>
        <li>1 tile range on main board</li>
        <li>Vs Infantry/Mech 1-4 (33%)</li>
        <li>IFV 1-3 (25%)</li>
        <li>MBT/All units in cities 1-2 (16%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Anti-Aircraft-D12</h5>
      <ul>
        <li>2 tile range on combat board</li>
        <li>Vs Aircraft 1-7 (58%)</li>
        <li>Vs SS missile 1-6 (50%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>SS-Artillery-D12</h5>
      <ul>
        <li>2 tile range on main board</li>
        <li>6 tile range on combat board</li>
        <li>vs Everything 1-8 (66%)</li>
      </ul>
    </div>
    <div class="text-center mb-4">
      <h2>Air Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Fighter Aircraft-D12</h5>
      <ul>
        <li>2 tile range on combat board</li>
        <li>1-4 (33%) on all ground targets</li>
        <li>Vs Figher 1-6 (50%)</li>
        <li>Vs CAS 1-9 (75%)</li>
        <li>Evade 1-5 (41%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Close Air Support-D12</h5>
      <ul>
        <li>1 tile range on combat board</li>
        <li>Cannot Target Fighters</li>
        <li>1-10 (83%) on all ground targets</li>
        <li>1-6 (50%) Vs CAS</li>
        <li>Evade 1-4 (33%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Transport Aircraft-D12</h5>
      <ul>
        <li>2 tile range on main board</li>
        <li>Evade 1-3 (25%)</li>
      </ul>
    </div>
    <div class="text-center mb-4">
      <h2>Navy Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Carrier-D12</h5>
      <ul>
        <li>Point Defense 1 tile range</li>
        <li>Vs Missiles 1-8 (66%)</li>
        <li>Vs Aircraft 1-6 (50%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5>Cruiser-D12</h5>
      <ul>
        <li>Point Defense 1 tile range</li>
        <li>CB AA 2 tile range 1-7 (58%)</li>
        <li>CB SS 3 tile range 1-9 (75%)</li>
        <li>AA Vs Aircraft 1-8 (66%)</li>
        <strong>
          <li>Cannon D12 1 tile range</li>
        </strong>
        <li>Vs Destroyer 1-4 (33%)</li>
        <li>Vs Cruiser 1-5 (41%)</li>
        <li>Vs Carrier 1-6 (50%)</li>
        <li>SS Missile 3 tile range MB</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5>Destroyer-D12</h5>
      <ul>
        <li>Cannon 1 tile range</li>
        <li>Vs Cruiser 1-8 (66%)</li>
        <li>Vs Carrier 1-9 (75%)</li>
        <li>Vs Destroyer 1-6 (50%)</li>
        <li>Vs land follow artillery rules</li>
        <li>Armor deflection D12 1-4 (33%)</li>
      </ul>
    </div>
    <div class="modal-footer text-end sticky-bottom no-border">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
    </div>
  </main>
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