<template>

  <body>
    <header class="sticky-top">
      <Navbar />
    </header>
    <main>
      <router-view />

    </main>

  </body>

  <!-- Claim Region Modal -->
  <section>
    <div class="modal fade" id="createRegion" tabindex="-1" aria-labelledby="createRegion" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="createRegion">Create Region</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
              title="close modal"></button>
          </div>
          <div class="modal-body">
            <CreateRegionForm />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Claim City Modal -->
  <section>
    <div class="modal fade" id="createCity" tabindex="-1" aria-labelledby="createCity" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="createCity">Create City</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
              title="close modal"></button>
          </div>
          <div class="modal-body">
            <CreateCityForm />
          </div>
          <div class="modal-footer">
            <h6>--Your Capital is 15 of each resource</h6>
            <h6>--Captured Capital is 10 of each resource</h6>
            <h6>--Medium City is 6 of each resource</h6>
            <h6>--Small City is 4 of each resource</h6>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Create Division Modal -->
  <section>
    <div class="modal fade" id="formDivision" tabindex="-1" aria-labelledby="formDivision" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="formDivision">Form Division</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
              title="close modal"></button>
          </div>
          <div class="modal-body">
            <CreateDivisionForm />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Create Army Modal -->
  <section>
    <div class="modal fade" id="formArmy" tabindex="-1" aria-labelledby="formArmy" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="formArmy">Form Army</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
              title="close modal"></button>
          </div>
          <div class="modal-body">
            <CreateArmyForm />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Create Carrier Group Modal -->
  <section>
    <div class="modal fade" id="formCarrierGroup" tabindex="-1" aria-labelledby="formCarrierGroup" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title fs-5" id="formCarrierGroup">Form Carrier Group</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" aria-label="Close"
              title="close modal"></button>
          </div>
          <div class="modal-body">
            <CreateCarrierGroup />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Unit Odds Modal -->
  <section>
    <div class="modal fade no-pad" id="unitOdds" tabindex="-1" aria-labelledby="UnitOddsModal" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title" id="unitOddsModal">Unit Odds</h1>
            <h6>*Attack Points(AP), Move Points(MP)</h6>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" title="close modal"
              aria-label="Close"></button>
          </div>
          <div class="modal-body">
            <UnitOddsRules />
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Unit Cost Modal -->
  <section>
    <div class="modal fade" id="unitCost" tabindex="-1" aria-labelledby="UnitCostModal" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title" id="unitCost">Unit Costs</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" title="close modal"
              aria-label="Close"></button>
          </div>
          <div class="modal-body no-pad">
            <UnitCostModal />
          </div>
        </div>
      </div>
    </div>
  </section>

</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import CreateArmyForm from "./components/CreateArmyForm.vue";
import CreateCarrierGroup from "./components/CreateCarrierGroup.vue";
import CreateCityForm from "./components/CreateCityForm.vue";
import CreateDivisionForm from "./components/CreateDivisionForm.vue";
import CreateRegionForm from "./components/CreateRegionForm.vue";
import Navbar from "./components/Navbar.vue";
import UnitCostModal from "./components/UnitCostModal.vue";
import UnitOddsRules from "./components/UnitOddsRules.vue";

export default {
  setup() {
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, CreateRegionForm, UnitOddsRules, UnitCostModal, CreateDivisionForm, CreateArmyForm, CreateCityForm, CreateCarrierGroup }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}

body {
  font-family: Impact, 'Arial Narrow Bold', sans-serif;
  letter-spacing: 1px;
  background-color: #606C38;
  background-image: linear-gradient(rgba(0, 0, 0, 0.5),
      rgba(0, 0, 0, 0.5)), url(../src/assets/img/TopoMap2.jpg);
  background-attachment: fixed;
  background-position: center right;
  background-repeat: no-repeat;
  background-size: cover;
  padding-right: 0 !important
}

button {
  box-shadow: black 4px 4px;
}

.bg-green {
  background-color: #606c3800;
}

.no-pad {
  padding: 0%;
}
</style>
