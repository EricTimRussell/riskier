<template>

  <body>

    <div class="card bg-primary" v-if="regions.ownerId == account.id">
      <div class="card-body">
        <h1>{{ regions.regionNumber }}|| {{ regions.creator.teamName }}</h1>
        <h4>Capital:{{ regions.capital }}</h4>
        <h4>Industry:{{ regions.industry }}</h4>
        <h4>Agriculture:{{ regions.agriculture }}</h4>
        <h4>{{ regions.environment }}</h4>
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

      // async getRegionsByOwnerId() {
      //   try {
      //     await regionTilesService.getRegionsByOwnerId(props.regions.ownerId)
      //   } catch (error) {
      //     Pop.error(error, "Getting regions by ownerId")
      //   }
      // }
    }
  }
}
</script>


<style lang="scss" scoped>
.select {
  cursor: pointer;
  color: #c10000;
}
</style>