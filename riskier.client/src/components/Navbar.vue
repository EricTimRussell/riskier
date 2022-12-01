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
    <!-- <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
      aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button> -->

  </body>


  <!-- Create Region Modal -->
  <div class="modal fade" id="createRegion" tabindex="-1" aria-labelledby="Create Region Modal" aria-hidden="true">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="exampleModalLabel">Create Region</h1>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
          <CreateRegionForm />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { AppState } from "../AppState";
import CreateRegionForm from "./CreateRegionForm.vue";
import Login from './Login.vue'
export default {
  setup(props) {
    return {
      account: computed(() => AppState.account)
    }
  },
  components: { Login, CreateRegionForm }
}
</script>

<style scoped>
.mr {
  margin-right: 3rem;
}
</style>
