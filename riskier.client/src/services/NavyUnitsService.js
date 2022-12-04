import { accountService } from "./AccountService"
import { api } from "./AxiosService"

class NavyUnitsService {
  async addCarrier() {
    const res = await api.post('api/navyUnits/carrier')
    accountService.getAccount()
  }

  async removeCarrier() {
    const res = await api.delete('api/navyUnits/carrier')
    accountService.getAccount()
  }
  async addCruiser() {
    const res = await api.post('api/navyUnits/cruiser')
    accountService.getAccount()
  }

  async removeCruiser() {
    const res = await api.delete('api/navyUnits/cruiser')
    accountService.getAccount()
  }
  async addDestroyer() {
    const res = await api.post('api/navyUnits/destroyer')
    accountService.getAccount()
  }

  async removeDestroyer() {
    const res = await api.delete('api/navyUnits/destroyer')
    accountService.getAccount()
  }
}
export const navyUnitsService = new NavyUnitsService()