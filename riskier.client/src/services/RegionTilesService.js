import { AppState } from "../AppState"
import { Region } from "../models/Region"
import Pop from "../utils/Pop"
import { accountService } from "./AccountService"
import { api } from "./AxiosService"

class RegionTilesService {

  async createRegion(formData) {
    const res = await api.post('api/regionTiles', formData)
    AppState.regions.push(new Region(res.data))
    accountService.getAccount()
  }

  async getRegionsByOwnerId(ownerId) {
    const res = await api.get('api/regionTiles/' + ownerId)
    console.log(res.data, "Regions");
    AppState.regions = res.data.map(r => new Region(r))
  }

  async getAllRegions() {
    const res = await api.get('api/regionTiles')
    console.log(res.data);
    AppState.regions = res.data.map(r => new Region(r))
  }

  async removeRegion(id) {
    const res = await api.delete('api/regionTiles/' + id)
    Pop.success("Region Removed")
    AppState.regions = AppState.regions.filter(r => r.id != id)
    accountService.getAccount()
  }
}
export const regionTilesService = new RegionTilesService()