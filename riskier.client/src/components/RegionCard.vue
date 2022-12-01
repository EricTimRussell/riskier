<template>

  <body>

    <div class="card bg-primary" v-if="regions.ownerId == account.id">
      <div class="card-body">
        <h1>{{ regions.regionNumber }}|| {{ regions.creator.teamName }}</h1>
        <h3>{{ regions.capital }}-Capital</h3>
        <h3>{{ regions.industry }}-Industry</h3>
        <h3>{{ regions.agriculture }}-Agriculture</h3>
      </div>
    </div>

  </body>

</template>


<script>
import { computed } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState";
import { Account } from "../models/Account";
import { Region } from "../models/Region";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";



export default {
  props: {
    regions: { type: Region, required: true },
  },
  setup(props) {
    // onMounted(() => {
    //   getRegionsByOwnerId()
    // })
    return {
      account: computed(() => AppState.account)
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

</style>