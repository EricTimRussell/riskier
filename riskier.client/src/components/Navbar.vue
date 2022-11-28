<template>

  <body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark px-3">
      <!-- Button trigger modal -->
      <button type="submit" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#createRegion">
        Create Region
      </button>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
        aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="d-flex justify-content-end collapse navbar-collapse" id="navbarText">
        <Login />
      </div>
    </nav>

  </body>


  <!-- Modal -->
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
import CreateRegionForm from "./CreateRegionForm.vue";
import Login from './Login.vue'
export default {
  setup() {

    return {

    }
  },
  components: { Login, CreateRegionForm }
}
</script>

<style scoped>

</style>
