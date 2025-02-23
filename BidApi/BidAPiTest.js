import http from 'k6/http';
import { sleep } from 'k6';

export const options = {
    vus: 10,
    duration: '10s',
    cloud: {
        // Project: BidAPITest
        projectID: 3749434,
        // Test runs with the same name groups test runs together.
        name: 'Test (22/02/2025-21:13:04)'
    },

    thresholds: {
        http_req_failed: ['rate<0.10'], // http errors should be less than 2%
        http_req_duration: ['p(95)<2000'], // 95% requests should be below 2s
    },
};

export default function () {

    http.get('https://localhost:7140/api/Bid');
    http.get('https://localhost:7140/api/User');

    http.post('https://localhost:7140/api/Bid');
    http.post('https://localhost:7140/api/User');
    http.put('https://localhost:7140/api/User');
    http.del('https://localhost:7140/api/User');
    
    sleep(1);
}