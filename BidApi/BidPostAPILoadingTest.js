import http from 'k6/http';
import { sleep } from 'k6';

export const
options = {
    vus: 210,
    duration: '100s',
    cloud: {
        // Project: BidAPITest
        projectID: 3749434,
        // Test runs with the same name groups test runs together.
        name: 'Test (22/02/2025-21:13:04)'
    },

};

export default function () {

    http.get('https://localhost:7140/api/Bid');


    sleep(1);
}