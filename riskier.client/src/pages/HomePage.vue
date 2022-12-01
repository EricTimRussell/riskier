<template>

  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-6 d-flex justify-content-evenly" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
    </div>



  </body>

</template>

<script>
import { authSettled, onAuthLoaded } from "@bcwdev/auth0provider-client";
import { computed } from "@vue/reactivity";
import { onMounted } from "vue";
import { AppState } from "../AppState";
import RegionCard from "../components/RegionCard.vue";
import { regionTilesService } from "../services/RegionTilesService";
import Pop from "../utils/Pop";

export default {
  setup() {
    async function getAllRegions() {
      try {
        await regionTilesService.getAllRegions()
      } catch (error) {
        Pop.error(error, "getting all regions")
      }
    }
    onAuthLoaded(() => {
      getAllRegions()
    })
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account)
    };
  },
  components: { RegionCard }
}
</script>

<style scoped lang="scss">

</style>
