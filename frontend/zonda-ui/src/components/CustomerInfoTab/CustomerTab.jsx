import { Box, Card, CardContent, Divider, Typography } from "@mui/material";

export default function CustomerTab({ customer }) {
  return (
    <Box>
      <Card variant="outlined">
        <CardContent>
          <Typography variant="h6" gutterBottom color="primary">
            Customer Info
          </Typography>
          <Divider sx={{ mb: 1 }} />
          <Typography variant="body2">
            <strong>Name:</strong> {customer.name}
          </Typography>
          <Typography variant="body2">
            <strong>Email:</strong> {customer.email}
          </Typography>
          <Typography variant="body2">
            <strong>Phone:</strong> {customer.phone}
          </Typography>
          <Typography variant="body2">
            <strong>Address:</strong> {customer.address}
          </Typography>
          <Typography variant="body2">
            <strong>Industry:</strong> {customer.industry}
          </Typography>
          <Typography variant="body2">
            <strong>Contact:</strong> {customer.contactPerson}
          </Typography>
          <Typography variant="body2">
            <strong>Since:</strong>{" "}
            {new Date(customer.registrationDate).toLocaleDateString()}
          </Typography>
        </CardContent>
      </Card>
    </Box>
  );
}
