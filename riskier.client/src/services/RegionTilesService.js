import { AppState } from "../AppState"
import { Region } from "../models/Region"
import { api } from "./AxiosService"

class RegionTilesService {

  async createRegion(formData) {
    const res = await api.post('api/regionTiles', formData)
    AppState.regions.push(new Region(res.data))
  }

  async getRegionsByOwnerId(ownerId) {
    const res = await api.get('api/regionTiles/' + ownerId)
    console.log(res.data, "Regions");
    AppState.regions = res.data.map(r => new Region(r))
  }

  async getAllRegions() {
    const res = await api.get('api/regionTiles')
    // console.log(res.data);
    AppState.regions = res.data.map(r => new Region(r))
  }

}
export const regionTilesService = new RegionTilesService()