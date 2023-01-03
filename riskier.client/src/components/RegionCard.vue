<template>

  <body>

    <div class="card-size bg-tan elevation-5 p-1" v-if="regions.ownerId == account.id">
      <div class="l-spacing">
        <h3 class="text-center">Region {{ regions.regionNumber }}</h3>
        <h3 class="text-center">Value</h3>
        <div class="text-center d-flex flex-column">
          <span class="mdi mdi-currency-usd fs-3">{{ regions.capital }}</span>
          <span class="mdi mdi-factory px-1 fs-3">{{ regions.industry }}</span>
          <span class="mdi mdi-barley fs-3">{{ regions.agriculture }}</span>
        </div>
      </div>
      <div class="text-end">
        <button @click="removeRegion()" class=" btn mdi mdi-delete-forever fs-3 select no-shadow"
          title="Delete?"></button>
      </div>
    </div>

  </body>

</template>


<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import { Region } from "../models/Region";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";
export default {
  props: {
    regions: { type: Region, required: true },
  },
  setup(props) {
    return {
      account: computed(() => AppState.account),
      async removeRegion() {
        try {
          if (await Pop.confirm("Remove Region?"))
            await regionTilesService.removeRegion(props.regions.id)
        } catch (error) {
          Pop.error(error, "Removing Region")
        }
      }
    }
  }
}
</script>


<style lang="scss" scoped>
.l-spacing {
  letter-spacing: 1px;
  color: black;
  text-shadow: white 2px 2px 2px;
}

.select {
  cursor: pointer;
  color: #c10000;
}

.bg-tan {
  background: linear-gradient(#FFDA96, #dda15e);
}

.card-size {
  max-height: 31vh;
  min-height: 31vh;
  min-width: 17vh;
  max-width: 17vh;
  border-radius: 5px;
}

.no-shadow {
  box-shadow: none;
  text-shadow: white 1px 1px;
}
</style>