import { AppState } from "../AppState"
import { api } from "./AxiosService"

class AssetsService {

  async createAssets(formData) {
    const res = await api.post('api/assets', formData)
    AppState.assets.push(res.data)
  }

  async addInfantry() {
    const res = await api.put('')
  }

}
export const assetsService = new AssetsService()