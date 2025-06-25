import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  IconButton,
  Typography,
  Box,
  Skeleton,
} from "@mui/material";
import { Delete } from "@mui/icons-material";

export default function ProductTable({
  products,
  isLoading,
  onEdit,
  onDelete,
}) {
  if (isLoading) {
    return (
      <Box mt={2}>
        <Skeleton variant="rectangular" height={200} />
      </Box>
    );
  }
  if (products.length === 0) {
    return (
      <Box mt={2}>
        <Typography variant="body1" color="textSecondary">
          No products to display.
        </Typography>
      </Box>
    );
  }

  return (
    <TableContainer component={Paper} sx={{ mt: 2 }}>
      <Table size="small">
        <TableHead>
          <TableRow>
            <TableCell>
              <strong>Id</strong>
            </TableCell>
            <TableCell>
              <strong>Name</strong>
            </TableCell>
            <TableCell>
              <strong>Price</strong>
            </TableCell>
            <TableCell align="right"></TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {products.map((product) => (
            <TableRow
              hover
              sx={{ cursor: "pointer" }}
              key={product.id}
              onClick={() => onEdit(product)}
            >
              <TableCell>{product.id}</TableCell>
              <TableCell>{product.name}</TableCell>
              <TableCell>${product.price.toFixed(2)}</TableCell>
              <TableCell align="right" onClick={(e) => e.stopPropagation()}>
                <IconButton color="error" onClick={() => onDelete(product.id)}>
                  <Delete />
                </IconButton>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
