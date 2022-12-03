import { AppState } from "../AppState"
import { accountService } from "./AccountService";
import { api } from "./AxiosService"

class LandUnitsService {

  async addInfantry() {
    const res = await api.post('api/landUnits')
    accountService.getAccount()
  }

  async removeInfantry() {
    const res = await api.delete('api/landUnits')
    accountService.getAccount()
  }




}
export const landUnitsService = new LandUnitsService()