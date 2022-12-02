<template>

  <body>
    <div class="container-fluid">
      <div class="row">
        <div class="col-6 col-md-3 d-flex justify-content-evenly my-2" v-for="r in regions">
          <RegionCard :regions="r" :key="r.id" />
        </div>
      </div>
      <div class="row justify-content-center">
        <div class="col-12 bg-dark">
          <CreateAssetsForm />
          <h1 class="text-center m-3">Assets</h1>
        </div>
        <!-- Assets component -->
      </div>
    </div>



  </body>

</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import CreateAssetsForm from "../components/CreateAssetsForm.vue";
import Navbar from "../components/Navbar.vue";
import RegionCard from "../components/RegionCard.vue";
import { assetsService } from "../services/AssetsService";
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
      account: computed(() => AppState.account),
      assets: computed(() => AppState.assets)
    };
  },
  components: { RegionCard, Navbar, CreateAssetsForm }
}
</script>

<style scoped lang="scss">
.pl {
  padding-left: 2rem;
}
</style>
