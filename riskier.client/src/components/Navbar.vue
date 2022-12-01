<template>

  <body>
    <div class="navbar-expand-lg navbar-dark bg-dark px-3 container-fluid">
      <div class="row">
        <div class=" d-flex col-md-4">
          <div>
            <Login class="navbar-collapse mr" id="navbarText" />
          </div>
          <div>
            <button type="submit" class="btn btn-primary my-2" data-bs-toggle="modal" data-bs-target="#createRegion"
              aria-label="Create Region">
              Create Region
            </button>
          </div>
        </div>
        <div class="col-md-8 col-sm-12 d-flex justify-content-start text-center">
          <h2>Capital: {{ account.totalCapital }}</h2>
          <h2 class="px-3">Industry: {{ account.totalIndustry }}</h2>
          <h2>Agriculture: {{ account.totalAgriculture }}</h2>
        </div>
      </div>
    </div>

  </body>



</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";

import Login from './Login.vue'
export default {
  setup() {
    return {
      account: computed(() => AppState.account)
    }
  },
  components: { Login }
}
</script>

<style scoped>
.mr {
  margin-right: 3rem;
}
</style>
