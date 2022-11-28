import { AppState } from "../AppState"
import { Region } from "../models/Region"
import { api } from "./AxiosService"

class RegionTilesService {

  async createRegion(formData) {
    const res = await api.post('api/regionTiles', formData)
    AppState.regions.push(new Region(res.data))
  }

}
export const regionTilesService = new RegionTilesService()