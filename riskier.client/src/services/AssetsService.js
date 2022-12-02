import { AppState } from "../AppState"
import { Asset } from "../models/Asset"
import { api } from "./AxiosService"

class AssetsService {

  async createAssets(formData) {
    const res = await api.post('api/assets', formData)
    AppState.assets.push(res.data)
  }

  async getAssets() {
    const res = await api.get('api/assets')
    console.log(res.data);
    AppState.assets = new Asset(res.data)
  }

  async addInfantry() {
    const res = await api.put('')
  }

}
export const assetsService = new AssetsService()