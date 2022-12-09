<template>

  <body>
    <header class="sticky-top">
      <Navbar />
    </header>
    <main>
      <router-view />
    </main>
    <footer class="sticky-bottom bg-green text-end px-3">
      <i class="mdi mdi-book-open-variant fs-1 text-light selectable" title="Rule Book" data-bs-toggle="modal"
        data-bs-target="#rulesModal"></i>
    </footer>
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
          <div class="modal-body">
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
import CreateRegionForm from "./components/CreateRegionForm.vue";
import Navbar from "./components/Navbar.vue";
import RulesModal from "./components/RulesModal.vue";
import UnitCostModal from "./components/UnitCostModal.vue";
import UnitOddsRules from "./components/UnitOddsRules.vue";


export default {
  setup() {
    return {
      appState: computed(() => AppState),
    };
  },
  components: { Navbar, CreateRegionForm, RulesModal, UnitOddsRules, UnitCostModal }
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
}

button {
  box-shadow: black 4px 4px;
}

.bg-green {
  background-color: #606c3800;
}
</style>
