import axios from "axios";
export default axios.create({
   baseURL: "https://localhost:7188",
   headers: {
    "Context-type": "application/json"
   }
});