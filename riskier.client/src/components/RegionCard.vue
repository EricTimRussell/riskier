<template>

  <body>

    <div class="card card-size bg-tan" v-if="regions.ownerId == account.id">
      <div class="card-body l-spacing">
        <h3 class="text-center">Region# {{ regions.regionNumber }}</h3>
        <h6 class="text-center"><strong>-Resources-</strong></h6>
        <div class="text-center">
          <h6>Capital: {{ regions.capital }}</h6>
          <h6>Industry: {{ regions.industry }}</h6>
          <h6>Agriculture: {{ regions.agriculture }}</h6>
        </div>
        <h6 class="text-center"><strong>Environment</strong></h6>
        <h6 class="text-center">{{ regions.environment }}</h6>
      </div>
      <div class="text-end">
        <span @click="removeRegion()" class="mdi mdi-delete-forever p-1 fs-3 select" title="Delete?"></span>
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
  letter-spacing: 2px;
  color: black;
  text-shadow: white 2px 2px 2px;
}

.select {
  cursor: pointer;
  color: #c10000;
}

.bg-tan {
  background-color: #FFDA96;
}

.card-size {
  max-height: 53vh;
}
</style>