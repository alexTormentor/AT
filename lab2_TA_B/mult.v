module mult(A, B, MULT, clock);
 
    input clock;
 
    input signed [16:0] A;
    input signed [16:0] B;
    
    output reg signed [32:0] MULT;
    
    reg signed [18:0] M;
    reg signed [32:0] X;
    
    integer i;
    
    always @ (posedge clock)
    begin
    
        M = B <<< 1;
        
        X = A;
        
        MULT = 33'b0;
            
        for (i = 0; i < 18; i = i + 2)
        begin
            case ({M[i + 2], M[i + 1], M[i]})
            3'b001: MULT = MULT + X;
            3'b010: MULT = MULT + X;
            3'b011: MULT = MULT + (X <<< 1);
            3'b100: MULT = MULT - (X <<< 1);
            3'b101: MULT = MULT - X;
            3'b110: MULT = MULT - X;
            default : ;
            endcase
        
            X = X << 2;         
        end
        
    end
    
endmodule