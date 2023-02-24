<template>
  <!-- SECTION Airfield -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.airfield <= 0)" @click="removeAirfield()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Airfield</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.airfield }}</strong></h6>
    </div>
    <div>
      <button @click="addAirfield()" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">2-<span class="mdi mdi-currency-usd text-warning"></span>1-<span
        class="mdi mdi-barley text-success"></span></span>
  </div>

  <!-- SECTION Naval Yard -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.navalYard <= 0)" @click="removeNavalYard()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Naval Yard</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.navalYard }}</strong></h6>
    </div>
    <div>
      <button @click="addNavalYard()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">2-<span class="mdi mdi-currency-usd text-warning"></span>2-<span
        class="mdi mdi-barley text-success"></span></span>
  </div>

  <!-- SECTION Warehouse currently not being used -->
  <!-- <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.warehouse <= 0)" @click="removeWarehouse()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Warehouse</h6>
      <h6 class="px-3 fs-4"><strong>{{ account.warehouse }}</strong></h6>
    </div>
    <div>
      <button @click="addWarehouse()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-5">
    <span class="fs-5">1-<span class="mdi mdi-currency-usd"></span> 1-<span class="mdi mdi-factory px-1"></span>
      3-<span class="mdi mdi-barley"></span></span>
  </div> -->

  <!-- SECTION Factory -->
  <div class="col-12 btn-group btn-group-sm d-flex justify-content-center" role="group" aria-label="Small button group">
    <div>
      <button :disabled="(account.factory <= 0)" @click="removeFactory()"
        class="btn btn-outline-dark mdi mdi-minus fs-2"></button>
    </div>
    <div class="d-flex flex-column align-items-center">
      <h6 class="px-2">Factory</h6>
      <h6 class="px-3 fs-4"><strong> {{ account.factory }} </strong></h6>
    </div>
    <div>
      <button @click="addFactory()" type="button" class="btn btn-outline-dark mdi mdi-plus fs-2"></button>
    </div>
  </div>
  <div class="col-12 d-flex justify-content-center mb-2">
    <span class="fs-5">2-<span class="mdi mdi-currency-usd text-warning"></span> 2-<span
        class="mdi mdi-factory px-1 text-secondary"></span>
      1-<span class="mdi mdi-barley text-success"></span></span>
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

      // Warehouses currently not being used in game
      // async addWarehouse() {
      //   try {
      //     await buildingsService.addWarehouse()
      //   } catch (error) {
      //     Pop.error(error, "Adding Warehouse")
      //   }
      // },

      // async removeWarehouse() {
      //   try {
      //     await buildingsService.removeWarehouse()
      //   } catch (error) {
      //     Pop.error(error, "Removing Warehouse")
      //   }
      // },

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
button {
  background: linear-gradient(#FFDA96, #dda15e);
}

button:disabled {
  background-color: #FFDA96;
}

button:active {
  box-shadow: none;
  background: linear-gradient(#606c38, #283618)
}

.mr {
  margin-right: 1rem;
}

.position-factory {
  position: relative;
  bottom: .1rem;
  left: 58vw;
}

.position-warehouse {
  position: relative;
  top: 1.6rem;
  left: 2.2rem;
}
</style>