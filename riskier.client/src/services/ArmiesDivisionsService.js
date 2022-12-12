import { AppState } from "../AppState"
import { Division } from "../models/Division"
import { api } from "./AxiosService"

class ArmiesDivisionsService {

  async formDivision(formData) {
    const res = await api.post('api/armiesDivisions/division', formData)
    console.log(res.data)
    AppState.divisions.push(new Division(res.data))
  }

}
export const armiesDivisionsService = new ArmiesDivisionsService()