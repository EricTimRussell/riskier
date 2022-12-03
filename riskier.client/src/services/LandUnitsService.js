import { AppState } from "../AppState"
import { accountService } from "./AccountService";
import { api } from "./AxiosService"

class LandUnitsService {

  async addInfantry() {
    const res = await api.post('api/landUnits/infantry')
    accountService.getAccount()
  }

  async removeInfantry() {
    const res = await api.delete('api/landUnits/infantry')
    accountService.getAccount()
  }

  async addSpecialForces() {
    const res = await api.post('api/landUnits/specialForces')
    accountService.getAccount()
  }

  async removeSpecialForces() {
    const res = await api.delete('api/landUnits/specialForces')
    accountService.getAccount()
  }



}
export const landUnitsService = new LandUnitsService()