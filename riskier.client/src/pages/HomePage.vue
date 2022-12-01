<template>
  <header class="sticky-top">
    <Navbar />
  </header>

  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-6 col-md-3 d-flex justify-content-evenly my-2" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
    </div>



  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import Navbar from "../components/Navbar.vue";
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
    return {
      regions: computed(() => AppState.regions),
      account: computed(() => AppState.account)
    };
  },
  components: { RegionCard, Navbar }
}
</script>

<style scoped lang="scss">

</style>
