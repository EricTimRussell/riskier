<template>
  <main>
    <div class="text-center mb-4">
      <h2>Land Unit Odds</h2>
      <h6>Tap to Select Section</h6>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck1">
      <label for="zoomCheck1">
        <h5 class="text-danger">Infantry: Offense-2D6</h5>
        <h6 class="text-center">1AP, 1MP, Range of 1</h6>
        <ul>
          <li>Vs Infantry: 5-8 (55.6%)</li>
          <li>Vs Mech: 7-10 (50%)</li>
          <li>Vs IFV: 7-8 (30.56%)</li>
          <li>Vs MBT: 7-10 (50%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck2">
      <label for="zoomCheck2">
        <h5 class="text-primary text-center">Infantry: Deffense-2D6</h5>
        <ul>
          <li>Urban D: 5-9 (66.7%)</li>
          <li>Wetlands D: 7-12 (58.3%) </li>
          <li>Jungle/Forest: D: 5-9 (66.7%)</li>
          <li>Desert/Grassland D: 7-9 (41.7%)</li>
          <li>Highlands D: 7-12 (58.3%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck3">
      <label for="zoomCheck3">
        <h5 class="text-danger text-center">Special Forces: Offense-2D6</h5>
        <h6 class="text-center">1AP, 1MP, Range of 1</h6>
        <ul>
          <li>Vs Infantry: 5-8, 11-12 (63.94%)</li>
          <li>Vs Mech: 7-12 (58.34%)</li>
          <li>Vs IFV: 7-8, 11-12 (38.9%)</li>
          <li>Vs MBT: 7-12 (58.34%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck4">
      <label for="zoomCheck4">
        <h5 class="text-primary text-center">Special Force: Deffense-2D6</h5>
        <ul>
          <li>Urban D: 5-9 (66.7%)</li>
          <li>Wetlands D: 7-12 (58.3%) </li>
          <li>Jungle/Forest: D: 5-9 (66.7%)</li>
          <li>Desert/Grassland D: 7-9 (41.7%)</li>
          <li>Highlands D: 7-12 (58.3%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck5">
      <label for="zoomCheck5">
        <h5 class="text-danger text-center">Mechanized: Offense-2D6</h5>
        <h6 class="text-center">1AP, 2MP, Range of 1</h6>
        <ul>
          <li>Vs Infantry: 5-9 (66.7%)</li>
          <li>Vs Mech: 7-11 (55.6%)</li>
          <li>Vs IFV: 2, 7-10 (52.8%)</li>
          <li>Vs MBT: 2, 7-9 (44.5%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck6">
      <label for="zoomCheck6">
        <h5 class="text-primary text-center">Mechanized: Deffense-2D6</h5>
        <ul>
          <li>Urban D: 7-12 (58.3%)</li>
          <li>Wetlands D: 7-9 (41.7%)</li>
          <li>Jungle/Forest D: 7-12 (58.3%)</li>
          <li>Desert/Grassland D: 7-10 (50%)</li>
          <li>Highlands D: 5-8 (55.6%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck7">
      <label for="zoomCheck7">
        <h5 class="text-danger text-center">IFV: Offense-2D6</h5>
        <h6 class="text-center">1AP, 3MP, Range of 1</h6>
        <ul>
          <li>Vs Infantry: 5-12 (77.8%)</li>
          <li>Vs Mech: 5-9 (66.7%)</li>
          <li>Vs IFV: 7-11 (55.6%)</li>
          <li>Vs MBT: 7-8 (30.6%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck8">
      <label for="zoomCheck8">
        <h5 class="text-primary text-center">IFV: Deffense-2D6</h5>
        <ul>
          <li>Urban D: 7-10 (50%)</li>
          <li>Wetlands D: 7-8 (30.6%)</li>
          <li>Jungle/Forest D: 7-9 (41.7%)</li>
          <li>Desert/Grassland D: 5-8 (55.6%)</li>
          <li>Highlands D: 7-10 (50%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck9">
      <label for="zoomCheck9">
        <h5 class="text-danger text-center">MBT: Offense-2D6</h5>
        <h6 class="text-center">2AP, 2MP, Range of 1</h6>
        <ul>
          <li>Vs Infantry: 2, 7-12 (61.1%)</li>
          <li>Vs Mech: 5-9 (66.7%)</li>
          <li>Vs IFV: 5-12 (77.8%)</li>
          <li>Vs MBT: 7-12 (58.3%) </li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck10">
      <label for="zoomCheck10">
        <h5 class="text-primary text-center">MBT: Deffense-2D6</h5>
        <ul>
          <li>Urban D: 7-10 (50%)</li>
          <li>Grassland/Desert D: 7-10 (50%)</li>
          <li>Forest D: 7-9 (41.7%)</li>
          <li>Highlands D: 7-9 (41.7%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck11">
      <label for="zoomCheck11">
        <h5 class="text-danger text-center">Artillery-D12</h5>
        <h6 class="text-center">1AP, 1MP, Range of 3</h6>
        <ul>
          <li>Vs Infantry/Mech 1-4 (33%)</li>
          <li>IFV 1-3 (25%)</li>
          <li>MBT/All units in cities 1-2 (16%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck12">
      <label for="zoomCheck12">
        <h5 class="text-danger text-center">Anti-Aircraft-D12</h5>
        <h6 class="text-center">1AP, 1MP, Range of 2</h6>
        <ul>
          <li>Vs Aircraft 1-7 (58%)</li>
          <li>Vs SS missile 1-6 (50%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck13">
      <label for="zoomCheck13">
        <h5 class="text-danger text-center">Missile Artillery-D12</h5>
        <h6 class="text-center">1AP, 1MP, Range of 4</h6>
        <ul>
          <li>Vs Infantry/Mech 1-4 (33%)</li>
          <li>IFV 1-3 (25%)</li>
          <li>MBT/All units in cities 1-2 (16%)</li>
          <li>With Laser Designator 1-7 Vs Everything</li>
        </ul>
      </label>
    </div>

    <div class="text-center my-4">
      <h2>Air Unit Odds</h2>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck14">
      <label for="zoomCheck14">
        <h5 class="text-danger text-center">Fighter Aircraft-D12</h5>
        <h6 class="text-center">1AP, 5MP, Range of 2</h6>
        <ul>
          <li>1-4 (33%) on all ground targets</li>
          <li>Vs Figher 1-6 (50%)</li>
          <li>Vs CAS 1-9 (75%)</li>
          <li>Evade 1-5 (41%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck15">
      <label for="zoomCheck15">
        <h5 class="text-danger text-center">Close Air Support-D12</h5>
        <h6 class="text-center">1AP, 3MP, Range of 1</h6>
        <ul>
          <li>Cannot Target Fighters</li>
          <li>1-10 (83%) on all ground targets</li>
          <li>1-6 (50%) Vs CAS</li>
          <li>Evade 1-4 (33%)</li>
        </ul>
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck16">
      <label for="zoomCheck16">
        <h5 class="text-danger text-center">Transport Aircraft-D12</h5>
        <ul>
          <li>2 tile range on main board</li>
          <li>Evade 1-3 (25%)</li>
        </ul>
      </label>
    </div>

    <div class="text-center my-4">
      <h2>Navy Unit Odds</h2>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck17">
      <label for="zoomCheck17">
        <h5 class="text-danger text-center">Aircraft Carrier-D12</h5>
        <h6 class="text-center">0AP, 1MP, Range of 1</h6>
        <ul>
          <li>Point Defense 1 tile range</li>
          <li>Vs Missiles 1-9 (75%)</li>
          <li>Vs Aircraft 1-6 (50%)</li>
        </ul>
      </label>
    </div>

    <div class="d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck18">
      <label for="zoomCheck18">
        <h5 class="text-danger text-center">Cruiser-D12</h5>
        <h6 class="text-center">1AP, 2MP</h6>
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
      </label>
    </div>

    <div class="bg-light d-flex flex-column align-items-center">
      <input type="checkbox" id="zoomCheck19">
      <label for="zoomCheck19">
        <h5 class="text-danger text-center">Destroyer-D12</h5>
        <h6 class="text-center">2AP, 2MP, 1 tile range</h6>
        <ul>
          <li>Vs Cruiser 1-8 (66%)</li>
          <li>Vs Carrier 1-9 (75%)</li>
          <li>Vs Destroyer 1-6 (50%)</li>
          <li>Vs land follow artillery rules</li>
          <li>Armor deflection D12 1-4 (33%)</li>
        </ul>
      </label>
    </div>

    <div class="modal-footer text-end sticky-bottom no-border pb-1">
      <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
    </div>

  </main>
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
.no-border {
  border: none;
}

input {
  display: none;
}

input:checked~label {
  transform: scale(1.3);
  background-color: #606c38;
  color: whitesmoke;
}

label {
  cursor: pointer;
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -khtml-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}
</style>