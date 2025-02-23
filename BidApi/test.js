import http from 'k6/http';
import { sleep, check } from 'k6';



export const options = {
    cloud: {
        projectID: 3749430,
        // Test runs with the same name groups test runs together
        name: 'BidAPI'
    }
}

export default function() {
  let res = http.get('https://quickpizza.grafana.com');
  check(res, { "status is 200": (res) => res.status === 200 });
  sleep(1);
}
