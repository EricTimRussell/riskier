<template>

  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeAirfield()" class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <h6 class="px-3">{{ account.airfield }}</h6>
    <div>
      <button @click="addAirfield()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeNavalYard()" class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <h6 class="px-3"> {{ account.navalYard }} </h6>
    <div>
      <button @click="addNavalYard()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-10 position-warehouse">
    <h6>Warehouse</h6>
  </div>
  <div class="col-4 position-factory">
    <h6>Factory</h6>
  </div>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeWarehouse()" class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <h6 class="px-3"> {{ account.warehouse }} </h6>
    <div>
      <button @click="addWarehouse()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-6 btn-group btn-group-sm px-2" role="group" aria-label="Small button group">
    <div>
      <button @click="removeFactory()" class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <h6 class="px-3"> {{ account.factory }} </h6>
    <div>
      <button @click="addFactory()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>

</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { buildingsService } from "../services/BuildingsService";
import Pop from "../utils/Pop";

export default {
  setup() {
    return {
      account: computed(() => AppState.account),
      async addAirfield() {
        try {
          await buildingsService.addAirfield()
        } catch (error) {
          Pop.error(error, "Adding Airfield")
        }
      },
      async removeAirfield() {
        try {
          await buildingsService.removeAirfield()
        } catch (error) {
          Pop.error(error, "Removing Airfield")
        }
      },
      async addNavalYard() {
        try {
          await buildingsService.addNavalYard()
        } catch (error) {
          Pop.error(error, "Adding NavalYard")
        }
      },
      async removeNavalYard() {
        try {
          await buildingsService.removeNavalYard()
        } catch (error) {
          Pop.error(error, "Removing NavalYard")
        }
      },
      async addWarehouse() {
        try {
          await buildingsService.addWarehouse()
        } catch (error) {
          Pop.error(error, "Adding Warehouse")
        }
      },
      async removeWarehouse() {
        try {
          await buildingsService.removeWarehouse()
        } catch (error) {
          Pop.error(error, "Removing Warehouse")
        }
      },
      async addFactory() {
        try {
          await buildingsService.addFactory()
        } catch (error) {
          Pop.error(error, "Adding Factory")
        }
      },
      async removeFactory() {
        try {
          await buildingsService.removeFactory()
        } catch (error) {
          Pop.error(error, "Removing Factory")
        }
      },
    }
  }
}
</script>


<style lang="scss" scoped>
.mr {
  margin-right: 1rem;
}

.position-factory {
  position: relative;
  bottom: .1rem;
  left: 54.5vw;
}

.position-warehouse {
  position: relative;
  top: 1.6rem;
  left: 2.2rem;
}
</style>