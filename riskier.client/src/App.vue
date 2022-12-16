<template>

  <body>
    <header class="sticky-top">
      <Navbar />
    </header>
    <main>
      <router-view />
    </main>

  </body>
  <RulesModal />

  <!-- Create Region Modal -->
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

  <!-- Form Division Modal -->
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

  <!-- Unit Odds Modal -->
  <section>
    <div class="modal fade" id="unitOdds" tabindex="-1" aria-labelledby="UnitOddsModal" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h1 class="modal-title" id="unitOddsModal">All Unit Odds</h1>
            <button type="button" class="btn-close bg-secondary" data-bs-dismiss="modal" title="close modal"
              aria-label="Close"></button>
          </div>
          <div class="modal-body no-pad">
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
import CreateDivisionForm from "./components/CreateDivisionForm.vue";
import CreateRegionForm from "./components/CreateRegionForm.vue";
import Navbar from "./components/Navbar.vue";
import RulesModal from "./components/RulesModal.vue";
import UnitCostModal from "./components/UnitCostModal.vue";
import UnitOddsRules from "./components/UnitOddsRules.vue";
import { accountService } from "./services/AccountService";
import Pop from "./utils/Pop";


export default {
  setup() {
    return {
      appState: computed(() => AppState),
      async resetGame() {
        try {
          await accountService.resetGame()
        } catch (error) {
          Pop.error(error, "reset game")
        }
      }
    };
  },
  components: { Navbar, CreateRegionForm, RulesModal, UnitOddsRules, UnitCostModal, CreateDivisionForm, CreateArmyForm }
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
  background-image: linear-gradient(rgba(0, 0, 0, 0.4),
      rgba(0, 0, 0, 0.4)), url(../src/assets/img/TopoMap2.jpg);
  background-attachment: fixed;
  background-position: center right;
  background-repeat: none;
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
