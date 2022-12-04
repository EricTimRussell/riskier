import { accountService } from "./AccountService"
import { api } from "./AxiosService"

class BuildingsService {

  async addAirfield() {
    const res = await api.post('api/buildings/airfield')
    accountService.getAccount()
  }

  async removeAirfield() {
    const res = await api.delete('api/buildings/airfield')
    accountService.getAccount()
  }

  async addNavalYard() {
    const res = await api.post('api/buildings/navalYard')
    accountService.getAccount()
  }

  async removeNavalYard() {
    const res = await api.delete('api/buildings/navalYard')
    accountService.getAccount()
  }

  async addWarehouse() {
    const res = await api.post('api/buildings/warehouse')
    accountService.getAccount()
  }

  async removeWarehouse() {
    const res = await api.delete('api/buildings/warehouse')
    accountService.getAccount()
  }

  async addFactory() {
    const res = await api.post('api/buildings/factory')
    accountService.getAccount()
  }

  async removeFactory() {
    const res = await api.delete('api/buildings/factory')
    accountService.getAccount()
  }

}
export const buildingsService = new BuildingsService()