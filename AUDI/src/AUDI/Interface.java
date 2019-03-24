package AUDI;

public class Interface extends javax.swing.JFrame {
    public Interface() {
        initComponents();
        brMotores.setStringPainted(true);
        brPneus.setStringPainted(true);
        brEletronicos.setStringPainted(true);
        brBancos.setStringPainted(true);
        brProducao.setStringPainted(true);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        panelAudi = new javax.swing.JPanel();
        lbMotores = new javax.swing.JLabel();
        brMotores = new javax.swing.JProgressBar();
        estoqueMotores = new javax.swing.JTextField();
        lbPneus = new javax.swing.JLabel();
        brPneus = new javax.swing.JProgressBar();
        estoquePneus = new javax.swing.JTextField();
        lbEletronicos = new javax.swing.JLabel();
        brEletronicos = new javax.swing.JProgressBar();
        estoqueEletronicos = new javax.swing.JTextField();
        lbBancos = new javax.swing.JLabel();
        lbCarroceria = new javax.swing.JLabel();
        brProducao = new javax.swing.JProgressBar();
        brBancos = new javax.swing.JProgressBar();
        estoqueBancos = new javax.swing.JTextField();
        estoqueCarrocerias = new javax.swing.JTextField();
        start = new javax.swing.JButton();
        lbEstoque = new javax.swing.JLabel();
        lbProducao = new javax.swing.JLabel();
        brCarrocerias = new javax.swing.JProgressBar();
        carreta = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("AUDI");
        setResizable(false);

        lbMotores.setText("Motores");

        brMotores.setStringPainted(true);

        estoqueMotores.setEditable(false);
        estoqueMotores.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        lbPneus.setText("Pneus");

        brPneus.setStringPainted(true);

        estoquePneus.setEditable(false);
        estoquePneus.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        lbEletronicos.setText("Eletrônicos");

        brEletronicos.setStringPainted(true);

        estoqueEletronicos.setEditable(false);
        estoqueEletronicos.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        lbBancos.setText("Bancos");

        lbCarroceria.setText("Carroceria");

        brProducao.setStringPainted(true);

        brBancos.setStringPainted(true);

        estoqueBancos.setEditable(false);
        estoqueBancos.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        estoqueCarrocerias.setEditable(false);
        estoqueCarrocerias.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        start.setText("Start");
        start.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                startActionPerformed(evt);
            }
        });

        lbEstoque.setText("Estoque");

        lbProducao.setText("PRODUÇÃO");

        brCarrocerias.setStringPainted(true);

        carreta.setEditable(false);
        carreta.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        javax.swing.GroupLayout panelAudiLayout = new javax.swing.GroupLayout(panelAudi);
        panelAudi.setLayout(panelAudiLayout);
        panelAudiLayout.setHorizontalGroup(
            panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelAudiLayout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(lbEstoque)
                .addGap(27, 27, 27))
            .addComponent(start, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(panelAudiLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lbEletronicos, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lbPneus, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lbMotores, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lbBancos, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lbCarroceria, javax.swing.GroupLayout.Alignment.TRAILING))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(carreta)
                    .addComponent(brProducao, javax.swing.GroupLayout.DEFAULT_SIZE, 194, Short.MAX_VALUE)
                    .addComponent(brEletronicos, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(brPneus, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(brMotores, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(brBancos, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(brCarrocerias, javax.swing.GroupLayout.DEFAULT_SIZE, 194, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.CENTER)
                    .addComponent(estoqueMotores)
                    .addComponent(estoquePneus)
                    .addComponent(estoqueEletronicos)
                    .addComponent(estoqueBancos, javax.swing.GroupLayout.DEFAULT_SIZE, 69, Short.MAX_VALUE)
                    .addComponent(estoqueCarrocerias))
                .addContainerGap())
            .addGroup(panelAudiLayout.createSequentialGroup()
                .addGap(135, 135, 135)
                .addComponent(lbProducao)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        panelAudiLayout.setVerticalGroup(
            panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelAudiLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lbEstoque)
                .addGap(5, 5, 5)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(brMotores, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbMotores)
                    .addComponent(estoqueMotores, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(brPneus, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(estoquePneus, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbPneus))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(brEletronicos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(estoqueEletronicos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbEletronicos))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(brBancos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(estoqueBancos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbBancos))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(panelAudiLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(estoqueCarrocerias, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbCarroceria)
                    .addComponent(brCarrocerias, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lbProducao)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(brProducao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(carreta, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(start)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panelAudi, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panelAudi, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void startActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_startActionPerformed
        new Thread(new Motor()).start();
        new Thread(new Pneus()).start();
        new Thread(new Eletronica()).start();
        new Thread(new Bancos()).start();
        new Thread(new Carroceria()).start();
        new Thread(new Producao()).start();
    }//GEN-LAST:event_startActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Interface.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Interface.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Interface.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Interface.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Interface().setVisible(true);
            }
        });
    }
    
    public class Motor implements Runnable{
        public void run(){
            int progresso=0;
            for(int motor=0; motor<=10;motor++, progresso=progresso+10){
                estoqueMotores.setText(""+motor);
                brMotores.setValue(progresso);
                try{
                    Thread.sleep(12000);
                }catch(Exception e){
                }
                
            }
        }
    }

    public class Pneus implements Runnable{
        public void run(){
            int progresso=0;
           for(int pneu=0;pneu<=100;pneu=pneu+4, progresso=progresso+4){
                brPneus.setValue(progresso);
                estoquePneus.setText(""+pneu);
                try{
                    Thread.sleep(9000);
                }catch(Exception e){
                }
            }
        }
    }
    
    public class Eletronica implements Runnable{
        public void run(){
            double progresso = 0;
            for(int eletronica=0; eletronica<=8;eletronica++, progresso = progresso + 12.5){
                brEletronicos.setValue((int)progresso);
                estoqueEletronicos.setText(""+eletronica);
                try{
                    Thread.sleep(7000);
                }catch(Exception e){
                    
                }
            }
        }
    }
    
    public class Bancos implements Runnable{
        public void run(){
            int progresso = 0;
            for(int bancos = 0; bancos <= 25; bancos = bancos +5, progresso = progresso + 20){
                brBancos.setValue(progresso);
                estoqueBancos.setText(""+bancos);
                try{
                    Thread.sleep(6000);
                }catch(Exception e){
                    
                }
            }
        }
    }
    
    public class Carroceria implements Runnable{
        public void run(){
            int progresso = 0;
            for(int carroceria=0; carroceria<=20;carroceria++, progresso = progresso+5){
                brCarrocerias.setValue(progresso);
                estoqueCarrocerias.setText(""+carroceria);
                try{
                    Thread.sleep(15000);
                }catch(Exception e){
                    
                }
            }
        }
    }
    
    public class Producao implements Runnable{
            public void run(){
               while(true){
                   if(estoqueBancos.getText().equals("25")==true
                           && estoqueEletronicos.getText().equals("8")==true
                           && estoqueMotores.getText().equals("10")==true
                           && estoquePneus.getText().equals("100")==true
                           && estoqueCarrocerias.getText().equals("20")==true){
                       for(int i = 0; i<=100; i++){
                           brProducao.setValue(i);
                           try{
                               Thread.sleep(40);
                           }catch(Exception e){
                               
                           }
                       }
                       carreta.setText("Produto Entregue!!!");
                       break;
                   }
               }               
            }
        }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JProgressBar brBancos;
    private javax.swing.JProgressBar brCarrocerias;
    private javax.swing.JProgressBar brEletronicos;
    private javax.swing.JProgressBar brMotores;
    private javax.swing.JProgressBar brPneus;
    private javax.swing.JProgressBar brProducao;
    private javax.swing.JTextField carreta;
    private javax.swing.JTextField estoqueBancos;
    private javax.swing.JTextField estoqueCarrocerias;
    private javax.swing.JTextField estoqueEletronicos;
    private javax.swing.JTextField estoqueMotores;
    private javax.swing.JTextField estoquePneus;
    private javax.swing.JLabel lbBancos;
    private javax.swing.JLabel lbCarroceria;
    private javax.swing.JLabel lbEletronicos;
    private javax.swing.JLabel lbEstoque;
    private javax.swing.JLabel lbMotores;
    private javax.swing.JLabel lbPneus;
    private javax.swing.JLabel lbProducao;
    private javax.swing.JPanel panelAudi;
    private javax.swing.JButton start;
    // End of variables declaration//GEN-END:variables
}
