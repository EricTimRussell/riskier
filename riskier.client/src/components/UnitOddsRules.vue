<template>

  <main>
    <div class="text-center mb-4">
      <h2>Land Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Infantry: Offense-2D6</h5>
      <h6>1AP, 1MP, Range of 1</h6>
      <ul>
        <li>Vs Infantry: 5-8 (55.6%)</li>
        <li>Vs Mech: 7-10 (50%)</li>
        <li>Vs IFV: 7-8 (30.56%)</li>
        <li>Vs MBT: 7-10 (50%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-primary">Infantry: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 5-9 (66.7%)</li>
        <li>Wetlands D: 7-12 (58.3%) </li>
        <li>Jungle/Forest: D: 5-9 (66.7%)</li>
        <li>Desert/Grassland D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-12 (58.3%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Special Forces: Offense-2D6</h5>
      <h6>1AP, 1MP, Range of 1</h6>
      <ul>
        <li>Vs Infantry: 5-8, 11-12 (63.94%)</li>
        <li>Vs Mech: 7-12 (58.34%)</li>
        <li>Vs IFV: 7-8, 11-12 (38.9%)</li>
        <li>Vs MBT: 7-12 (58.34%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-primary">Special Force: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 5-9 (66.7%)</li>
        <li>Wetlands D: 7-12 (58.3%) </li>
        <li>Jungle/Forest: D: 5-9 (66.7%)</li>
        <li>Desert/Grassland D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-12 (58.3%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Mech: Offense-2D6</h5>
      <h6>1AP, 2MP, Range of 1</h6>
      <ul>
        <li>Vs Infantry: 5-9 (66.7%)</li>
        <li>Vs Mech: 7-11 (55.6%)</li>
        <li>Vs IFV: 2, 7-10 (52.8%)</li>
        <li>Vs MBT: 2, 7-9 (44.5%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-primary">Mech: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-12 (58.3%)</li>
        <li>Wetlands D: 7-9 (41.7%)</li>
        <li>Jungle/Forest D: 7-12 (58.3%)</li>
        <li>Desert/Grassland D: 7-10 (50%)</li>
        <li>Highlands D: 5-8 (55.6%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">IFV: Offense-2D6</h5>
      <h6>1AP, 3MP, Range of 1</h6>
      <ul>
        <li>Vs Infantry: 5-12 (77.8%)</li>
        <li>Vs Mech: 5-9 (66.7%)</li>
        <li>Vs IFV: 7-11 (55.6%)</li>
        <li>Vs MBT: 7-8 (30.6%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-primary">IFV: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-10 (50%)</li>
        <li>Wetlands D: 7-8 (30.6%)</li>
        <li>Jungle/Forest D: 7-9 (41.7%)</li>
        <li>Desert/Grassland D: 5-8 (55.6%)</li>
        <li>Highlands D: 7-10 (50%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">MBT: Offense-2D6</h5>
      <h6>2AP, 2MP, Range of 1</h6>
      <ul>
        <li>Vs Infantry: 2, 7-12 (61.1%)</li>
        <li>Vs Mech: 5-9 (66.7%)</li>
        <li>Vs IFV: 5-12 (77.8%)</li>
        <li>Vs MBT: 7-12 (58.3%) </li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-primary">MBT: Deffense-2D6</h5>
      <ul>
        <li>Urban D: 7-10 (50%)</li>
        <li>Grassland/Desert D: 7-10 (50%)</li>
        <li>Forest D: 7-9 (41.7%)</li>
        <li>Highlands D: 7-9 (41.7%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Artillery-D12</h5>
      <h6>1AP, 1MP, Range of 3</h6>
      <ul>
        <li>Vs Infantry/Mech 1-4 (33%)</li>
        <li>IFV 1-3 (25%)</li>
        <li>MBT/All units in cities 1-2 (16%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-danger">Anti-Aircraft-D12</h5>
      <h6>1AP, 1MP, Range of 2</h6>
      <ul>
        <li>Vs Aircraft 1-7 (58%)</li>
        <li>Vs SS missile 1-6 (50%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">SS-Artillery-D12</h5>
      <h6>1AP, 1MP, Range of 4</h6>
      <ul>
        <li>Vs Infantry/Mech 1-4 (33%)</li>
        <li>IFV 1-3 (25%)</li>
        <li>MBT/All units in cities 1-2 (16%)</li>
        <li>With Laser Designator 1-7 Vs Everything</li>
      </ul>
    </div>
    <div class="text-center mb-4">
      <h2>Air Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Fighter Aircraft-D12</h5>
      <h6>1AP, 5MP, Range of 2</h6>
      <ul>
        <li>1-4 (33%) on all ground targets</li>
        <li>Vs Figher 1-6 (50%)</li>
        <li>Vs CAS 1-9 (75%)</li>
        <li>Evade 1-5 (41%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-danger">Close Air Support-D12</h5>
      <h6>1AP, 3MP, Range of 1</h6>
      <ul>
        <li>Cannot Target Fighters</li>
        <li>1-10 (83%) on all ground targets</li>
        <li>1-6 (50%) Vs CAS</li>
        <li>Evade 1-4 (33%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Transport Aircraft-D12</h5>
      <ul>
        <li>2 tile range on main board</li>
        <li>Evade 1-3 (25%)</li>
      </ul>
    </div>
    <div class="text-center mb-4">
      <h2>Navy Unit Odds</h2>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Carrier-D12</h5>
      <h6>0AP, 1MP, Range of 1</h6>
      <ul>
        <li>Point Defense 1 tile range</li>
        <li>Vs Missiles 1-9 (75%)</li>
        <li>Vs Aircraft 1-6 (50%)</li>
      </ul>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h5 class="text-danger">Cruiser-D12</h5>
      <h6>1AP, 2MP</h6>
      <ul>
        <li>CB AA 2 tile range 1-7 (58%)</li>
        <li>CB SS 4 tile range 1-8 (75%)</li>
        <li>SS Vs land units follow SS-Artillery rules</li>
        <strong>
          <li>Cannon D12 1 tile range</li>
        </strong>
        <li>Vs Destroyer 1-4 (33%)</li>
        <li>Vs Cruiser 1-5 (41%)</li>
        <li>Vs Carrier 1-6 (50%)</li>
      </ul>
    </div>
    <div class="bg-light d-flex flex-column align-items-center">
      <h5 class="text-danger">Destroyer-D12</h5>
      <h6>2AP, 2MP, 1 tile range</h6>
      <ul>
        <li>Vs Cruiser 1-8 (66%)</li>
        <li>Vs Carrier 1-9 (75%)</li>
        <li>Vs Destroyer 1-6 (50%)</li>
        <li>Vs land follow artillery rules</li>
        <li>Armor deflection D12 1-4 (33%)</li>
      </ul>
    </div>
    <div class="modal-footer text-end sticky-bottom no-border pb-5">
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